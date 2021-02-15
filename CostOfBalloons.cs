using System.IO;
using System;

class Program
{
    static void Main()
    {
        int T=Convert.ToInt32(Console.ReadLine());
        for (int j=0;j<T;j++)
            {
    
               
                string CostStr=Console.ReadLine();
                string[] costs=CostStr.Split(null);
                int cost1=Int32.Parse(costs[0]);
                int cost2=Int32.Parse(costs[1]);
                int n=Convert.ToInt32(Console.ReadLine());
                int firstProblem=0;
                int secondProblem=0;

                for(int i=0;i<n;i++)
                {
                    string input=Console.ReadLine();
                    string[] ques=input.Split(null);
                    int ques1=Int32.Parse(ques[0]);
                    int ques2=Int32.Parse(ques[1]);
                    if(ques1==1)
                        firstProblem++;
                    if(ques2==1)
                        secondProblem++;
                }
                int totalCost=0;
                if(cost1>cost2)
                {
                    if(firstProblem>secondProblem)
                    {
                        totalCost=firstProblem*cost2+secondProblem*cost1;
                    }
                    else
                    {
                        totalCost=firstProblem*cost1+secondProblem*cost2;
                    }
                }
                else
                {
                if(firstProblem>secondProblem)
                    {
                        totalCost=firstProblem*cost1+secondProblem*cost2;
                    }
                    else
                    {
                        totalCost=firstProblem*cost2+secondProblem*cost1;
                    }  
                }
                Console.WriteLine(totalCost);
            }
}
}