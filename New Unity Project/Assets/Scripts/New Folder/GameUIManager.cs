using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

public class GameUIManager : MonoBehaviour
{
    public GameObject btnPause;//暂停按钮
    public GameObject btnPhoto;//截屏按钮
    public GameObject btnPanel;//截屏显示面板
    public Image imgCapture;//截屏显示面板上的显示截屏用的Image控件

    private Texture2D image;//存储截屏纹理图
    public Texture2D Logo;//水印图

    string filename = null;//存储的文件名

    public void TakePhoto()
    {
        Time.timeScale = 0;
        //这个是Unity自带的截屏操作方法，全屏并保存到文件中（不好加水印）
        //Application.CaptureScreenshot("Screenshot.png", 0);
        btnPause.SetActive(false);
        btnPhoto.SetActive(false);
        //使用协程解决ReadPixel报错
        StartCoroutine(Capture());
    }

    Texture2D CaptureScreenshot(Rect rect)
    {
        // 先创建一个的空纹理，大小可根据实现需要来设置  
        Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        // 读取屏幕像素信息并存储为纹理数据，  
        screenShot.ReadPixels(rect, 0, 0);
        screenShot.Apply();
        //把Logo处理成350X200大小
        Texture.Bilinear(Logo, 350, 200);
        //在截图上加上水印
        Texture2D results = AddWatermark(screenShot, Logo, 50, 50);
        // 然后将这些纹理数据，生成一个png图片文件  
        byte[] bytes = results.EncodeToPNG();
        //如果是Editor环境
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            //定义截图保存路径
            filename = Application.dataPath + "/screencapture" + System.Guid.NewGuid().ToString("N") + ".png";
        }
        else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //定义截图保存路径，Android和ios要使用Application.persistentDataPath
            filename = Application.persistentDataPath + "/screencapture" + System.Guid.NewGuid().ToString("N") + ".png";
        }
        System.IO.File.WriteAllBytes(filename, bytes);
        return results;
    }
    //截屏
    IEnumerator Capture()
    {
        yield return new WaitForEndOfFrame();
        image = CaptureScreenshot(new Rect(0, 0, Screen.width * 1f, Screen.height * 1f));
        btnPanel.SetActive(true);
        //显示截屏后的图
        imgCapture.GetComponent<Image>().sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(1f, 1f));
    }

    //添加水印
    private Texture2D AddWatermark(Texture2D background, Texture2D watermark, int startX, int startY)
    {
        Texture2D newTex = new Texture2D(background.width, background.height, background.format, false);
        for (int x = 0; x < background.width; x++)
        {
            for (int y = 0; y < background.height; y++)
            {
                if (x >= startX && y >= startY && x < watermark.width && y < watermark.height)
                {
                    Color bgColor = background.GetPixel(x, y);
                    Color wmColor = watermark.GetPixel(x - startX, y - startY);

                    Color final_color = Color.Lerp(bgColor, wmColor, wmColor.a / 1.0f);

                    newTex.SetPixel(x, y, final_color);
                }
                else
                    newTex.SetPixel(x, y, background.GetPixel(x, y));
            }
        }
        newTex.Apply();
        return newTex;
    }

    //调用Android的系统分享功能实现分享
    public void ShareImage()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            // block to open the file and share it ------------START
            AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", filename);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

            intentObject.Call<AndroidJavaObject>("setType", "text/plain");
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "" + "Eu Fui!");
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "SUBJECT");

            intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");
            //这个地方暂时没有解决，分享后回到界面
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

            currentActivity.Call("startActivity", intentObject);
        }
    }
}
