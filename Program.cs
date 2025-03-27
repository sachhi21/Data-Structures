// See https://aka.ms/new-console-template for more information
using Data_Structures.InterviewQuestions;
using Data_Structures.Utils;

class Program
{
    static void Main(string[] args)
    {   
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






    }
}
