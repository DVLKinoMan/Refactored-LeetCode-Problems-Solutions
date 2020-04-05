namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Best Time to Buy and Sell Stock II
      /// </summary>
      /// <param name="prices"></param>
      /// <returns></returns>
      public static int MaxProfit2_1(int[] prices) {
         int total = 0;
         for (int i=0; i< prices.Length-1; i++) 
            if (prices[i+1]>prices[i])
               total += prices[i+1]-prices[i];
    
         return total;
      }
   }
}