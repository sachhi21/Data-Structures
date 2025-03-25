// See https://aka.ms/new-console-template for more information
using Data_Structures.Utils;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Maths.parseInt("5021"));
        Node newroot = new Node("sachin", null);
        Incident incident = new Incident();
        incident.Id = 1;
        incident.IncidentName = "Incident1";
        Incident incident2 = new Incident();    
        incident2.Id = 2;
        incident2.IncidentName = "Incident2";
        CustomLinkedList linkedList = new CustomLinkedList();
        linkedList.add(incident);
        linkedList.add(incident2);
        linkedList.add(incident);
        linkedList.print();
        
        
    }
}
