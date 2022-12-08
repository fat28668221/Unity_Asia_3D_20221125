using UnityEngine;
using System.Collections;

namespace Justin
{

    /// <summary>
    /// 學習偕同程序，簡稱協成 Coroutine
    /// 目的:讓程式停留達到等待的結果
    /// </summary>
    public class NewBehaviourScript : MonoBehaviour
    {
        //使用協同程序的三個條件
        //1.引用命名空間 System.Collections
        //2.定義一個回傳 IEnumerator 的方法
        //3.方法內必須使用 yieldreturn(等待)
        //4.使用 StarCoroutine 啟動

        //字串 string 為 char 陣列
        private string testDialogue = "我是誰? 我在哪?";

        private void Awake()
        {
         ///StartCoroutine(Test());
         ///print("取得測試對話的第一格字:" + testDialogue[0]);
         ///StartCoroutine(ShowDialogue());
        }
        private IEnumerator Test()
        {
            print("<color=#33ff33>第一行程式</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式</color>");
            yield return new WaitForSeconds(3);
            print("<color=#3333ff>第三行程式</color>");
        }
        private IEnumerator ShowDialogue()
        {
            print(testDialogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(testDialogue[1]);
            yield return new WaitForSeconds(0.1f); 
            print(testDialogue[2]);
            yield return new WaitForSeconds(0.1f);
        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < testDialogue.Length; i++)
            {
                print(testDialogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
    
    
}




