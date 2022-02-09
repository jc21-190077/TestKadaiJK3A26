using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {

        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int s)
        {


            int[] current = new int[edgeFirst.Length];
            int[] searched = new int[edgeNext.Length];
            int[] path = new int[edgeNext.Length];
            int[] start = {1,2,3,4,2,5,4,6};
            int[] end = {2,3,4,1,5,4,6,2};


            for (int i = 0; i < edgeFirst.Length; i++)
            {
                current[i] = edgeFirst[i];

            }

            int top = 1;
            int last = edgeNext.Length;
            int temp = 0;
            int x = 1;


            while (1 <= last)
            {
                if (current[x -1] != 0)
                {
                    temp = current[x -1];
                    searched[top -1] = temp;
                    current[x -1] = edgeNext[temp -1];
                    x = end[temp -1];
                    top++;

                }
                else
                {
                    top--;
                    temp = searched[top - 1];
                    path[last -1] = temp;
                    x = start[temp -1];
                    last--;
                }                
            }
            return path;
        }
    }
}

