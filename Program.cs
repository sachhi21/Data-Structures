// See https://aka.ms/new-console-template for more information
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
        Node newroot = new Node(incident, null);

        CustomLinkedList linkedList = new CustomLinkedList();
        linkedList.add(incident);
        linkedList.add(incident2);
        linkedList.add(incident);
        linkedList.print();
   //     linkedList.Search(incident2);
        linkedList.Remove(incident);
        linkedList.Remove(incident);

        GenericNode<int> node = new GenericNode<int>(10, null);
        GenericLinkedList<int> genericLinkedList = new GenericLinkedList<int>();
        genericLinkedList.Add(10);

        genericLinkedList.Add(20);
        genericLinkedList.Add(30);

        genericLinkedList.Add(40);
        genericLinkedList.Add(50);
        genericLinkedList.Add(60);
        node = RemoveKthLinkedListEnd<int>.RemoveKthFromEndFromLinkedList(genericLinkedList.head, 2);


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





    }
}
