using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {

        public static int ride(int k,int[] g ,int r)
        {
            int deq = 0;            //deqの取り出し先
            int mid = 0;            //途中経過
            int result = 0;         //結果     
            int peek = 0;           //peekの取り出し先
            int tem = 0;            //over判定
            int count = 0;

            var que = new Queue<int>();
            
            for(int s = 0; s < g.Length; s++)
            {
                que.Enqueue(g[s]);            
            }

            for (int i  = 0;i < r;i++){

                for (int j = 0 ; j < k; )
                {        
                    
                    if(count == g.Length)
                    {
                        count = 0;
                        break;
                    }

                    peek = que.Peek();
                    tem += peek;
                    
                    if (tem > k)
                    {
                        tem = 0;
                        break;
                    }

                    deq = que.Dequeue();
                    j += deq;
                    mid = j;
                
                    if(j > k)
                    {
                        mid -= deq;
                        break;
                    }
                    que.Enqueue(deq);
                    count++;
                }
                count = 0;
                result += mid;
            }
            return result;
        }

    }
}
