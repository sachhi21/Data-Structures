// See https://aka.ms/new-console-template for more information
using Data_Structures.InterviewQuestions;
using Data_Structures.Utils;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {


        timeConversion.s12Into24hour("07:05:45PM");
        // Test case 1: Alice wins
        int[] piles1 = { 3, 7, 2, 3 };
        Console.WriteLine(StoneGame.StoneGameWin(piles1));  // Output: True (Alice wins)

        // Test case 2: Alice wins
        int[] piles2 = { 5, 3, 4, 5 };
        Console.WriteLine(StoneGame.StoneGameWin(piles2));  // Output: True (Alice wins)

        // Test case 3: Bob wins
        int[] piles3 = { 1, 5, 233, 7 };
        Console.WriteLine(StoneGame.StoneGameWin(piles3));  // Output: True (Alice wins)
    
    int[][] matrix = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 0, 6},
    new int[] {7, 8, 9}
};
        ListNode node1 = new ListNode(10);

        ListNode node2 = new ListNode(20);
        ListNode node3= new ListNode(30);
        ListNode node4 = new ListNode(40);
        ListNode node5 = new ListNode(50);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;


        node1 = RemoveNthFromEndLinkedList.RemoveNthFromEnd(node1, 2);

        //int[,] numbers = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        SetZerosMatrix.PrintMatrix(SetZerosMatrix.SetZeroes(matrix));
        WordDistance.MinDistance("horse", "ros");
        string input = "/home/user/./Downloads/../Pictures/././";
        string input2 = "/a/../../b/../c//.//";
        string input3 = "/";
        string input4 = "/.../a/../b/c/../d/./";
        Console.WriteLine(SimplyPathUnix.SimplifyPath(input));
        string ouput2 = SimplyPathUnix.SimplifyPath(input2);
        string ouput3 = SimplyPathUnix.SimplifyPath(input3);
        string ouput4 = SimplyPathUnix.SimplifyPath(input4);

        int steps = 4;        
                                                          
        Stack<Stair> stairsStack = new Stack<Stair>();

        // Starting at step 0 with an empty list of visited steps
        stairsStack.Push(new Stair(0, new List<List<int>>()));

        while (stairsStack.Count > 0)
        {
            Stair currentStair = stairsStack.Pop();
            if (currentStair._number == steps)
            {
                // Print all visited paths when the goal is reached
                Console.WriteLine("Path to reach step " + steps + ":");
                foreach (var path in currentStair._visited)
                {
                    Console.WriteLine(string.Join(" -> ", path));
                }
                Console.WriteLine(); // Newline for clarity
            }

            // Generate possible next steps
            int nextonestair = currentStair._number + 1;
            int nexttwostair = currentStair._number + 2;

            // Check if next steps are valid and add to the stack
            if (nextonestair <= steps)
            {
                var newVisited = new List<List<int>>(currentStair._visited);
                newVisited.Add(new List<int>(currentStair._visited.Count == 0 ? new List<int> { 0 } : currentStair._visited[^1])); // Copy last visited
                newVisited[^1].Add(nextonestair); // Add the current step to the path
                stairsStack.Push(new Stair(nextonestair, newVisited));
            }

            if (nexttwostair <= steps)
            {
                var newVisited = new List<List<int>>(currentStair._visited);
                newVisited.Add(new List<int>(currentStair._visited.Count == 0 ? new List<int> { 0 } : currentStair._visited[^1])); // Copy last visited
                newVisited[^1].Add(nexttwostair); // Add the current step to the path
                stairsStack.Push(new Stair(nexttwostair, newVisited));
            }
        }
         



        StackArray<int> stack = new StackArray<int>(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        Console.WriteLine(stack.pop());    
        List<int> ints = new List<int>() { 1,2,2,3,4,56,4,8,9};
        ints = UniqueNumber.FindUniqueNumber(ints);
        Console.WriteLine(Maths.parseInt("5021"));
        Incident incident = new Incident();
        incident.Id = 1;
        incident.IncidentName = "Incident1";
        Incident incident2 = new Incident();    
        incident2.Id = 2;
        incident2.IncidentName = "Incident2";
        Node newroot = new Node(incident);

        CustomLinkedList linkedList = new CustomLinkedList();
        linkedList.add(incident);
        linkedList.add(incident2);
        linkedList.add(incident);
        linkedList.print();
       //linkedList.Search(incident2);
        linkedList.Remove(incident);
        linkedList.Remove(incident);

        GenericNode<int> node = new GenericNode<int>(10);
        GenericLinkedList<int> genericLinkedList = new GenericLinkedList<int>();
        GenericLinkedList<int> genericLinkedList2 = new GenericLinkedList<int>();

        genericLinkedList.Add(10);

        genericLinkedList.Add(20);
        genericLinkedList.Add(30);

        genericLinkedList.Add(40);
        genericLinkedList.Add(50);
        //genericLinkedList.Add(60);
        genericLinkedList2.Add(60);
        genericLinkedList2.Add(70);
        genericLinkedList2.Add(80);
        genericLinkedList2.Add(90);
        genericLinkedList2.Add(100);

        GenericLinkedList<int> resultMerged = MergeLinkedListOppositeOrder<int>.MergeLinkedListOpposite(genericLinkedList,genericLinkedList2);
        genericLinkedList.Print(resultMerged.head);


        node = RemoveKthLinkedListEnd<int>.RemoveKthFromEndFromLinkedList(genericLinkedList.head, 2);

        genericLinkedList.Print(resultMerged.head);
        genericLinkedList.Remove(30);
        genericLinkedList.Print();

        GenericNode<int> n = genericLinkedList.Search(50);

        GenericDoubleLinkedList<int> genericDoubleLinkedList = new GenericDoubleLinkedList<int>();  
        genericDoubleLinkedList.AddLast(50);
        genericDoubleLinkedList.AddLast(10);
        genericDoubleLinkedList.AddLast(20);
        genericDoubleLinkedList.AddLast(30);
        genericDoubleLinkedList.AddLast(50);
        genericDoubleLinkedList.AddFirst(100);
        genericDoubleLinkedList.PrintForward();
        genericDoubleLinkedList.PrintBackward();

        Console.WriteLine( CommonWord.FindCommonWord("sss sss sss d ss ee rr ffg"));
        Console.WriteLine(FirstUniqueCharacter.FindUniqueChar("SACHINRAMPUR"));
        Console.WriteLine(SecondUniqueChar.FindUniqueChar("SACHINRAMPUR"));
        Console.WriteLine(LastUniqueChar.FindLastUniqueChar("SACHINRAMPUR"));
        ArraySum.Sum(new List<int> { 1, 2, 3, 4, 5, 6, });
        List<int>  l = new List<int>();
        l =  CompareTriplets.compareTriplets(new List<int> { 1, 2, 3 }, new List<int> { 3, 2, 1 });


    }
}
