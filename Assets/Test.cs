using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53;
    
    public void Magic(int pp)
    {
         

        if(mp >= 5 )
        {
  
              
            this.mp -= pp;   
            Debug.Log("魔法攻撃をした。残りMPは"+ mp+"。");
            
            
        } 
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
     
          }

    }





public class Test : MonoBehaviour
{
        
    void Start()
    {
        // int[] array = new int[5];

        // array[0] = 10;
        // array[1] = 20;
        // array[2] = 30;
        // array[3] = 40;
        // array[4] = 50;

        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log (array [i]);
        // }

        // for (int i = 4; i >= 0; i--)
        // {
        //     Debug.Log (array [i]);
        // }

        Boss lastboss = new Boss ();
        for(int i = 0; i<=10; i++ )
        {
            lastboss.Magic(5);
        }
        


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// public class Test2 : MonoBehaviour
// {
        
//     void Start()
//     {
//         int[] array = new int[5];

//         array[0] = 10;
//         array[1] = 20;
//         array[2] = 30;
//         array[3] = 40;
//         array[4] = 50;

//         for (int i = 0; i < 5; i++)
//         {
//             Debug.Log (array [i]);
//         }

//         for (int i = 4; i >= 0; i--)
//         {
//             Debug.Log (array [i]);
//         }
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }