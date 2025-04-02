//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data_Structures.InterviewQuestions
//{
//    public class StairStack
//    {
//        public static void Main(string[] args)
//        {
//            int steps = 4;

//            Stack<Stair> stairsStack = new Stack<Stair>();

//            stairsStack.Push(new Stair(0, new System.Collections.ArrayList()));

//            while (!stairsStack.Any())
//            {

//                Stair currentStair = stairsStack.Pop();
//                if (currentStair._number == steps)
//                {
//                    Console.WriteLine(currentStair._visited);
//                }

//                int nextonestair = currentStair._number + 1;
//                int nexttwostair = currentStair._number + 2;
//                if(nextonestair <= steps)
//                {
//                    stairsStack.Push(new Stair(nextonestair, currentStair._visited));
//                }
//                if (nexttwostair <= steps)
//                {
//                    stairsStack.Push(new Stair(nexttwostair, currentStair._visited));
//                }


//            }


//        }
//    }
//}
