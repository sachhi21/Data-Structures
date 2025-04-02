using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class Stair
    {
        public int _number;
        public  List<List<int>> _visited;

        public Stair(int number , List<List<int>>  visited)
        {
            _number = number;
            _visited = new List<List<int>>(visited);
        }



    }
}
