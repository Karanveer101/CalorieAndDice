using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]

        public string DiceGame(int m, int n)
        {

            //array of possible combinations
            int[] combinations = new int[m*n];


            //The sum of combinations are added to combinations array
            int k = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    combinations[k++] = i + j;
                }
            }
            
            //This loop counts the number of times the sum of 10 is achieved
            int count = 0;
            for (int i = 0; i < combinations.Length; i++)
            {

                if (combinations[i] == 10)
                {
                    count = count + 1;
                }

            }

            return "There are " + count + " total ways to get the sum 10";
        }

    }
}