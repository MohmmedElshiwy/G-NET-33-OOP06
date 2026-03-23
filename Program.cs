namespace G_NET_33_OOP06;

public class Program
{
    static void Main(string[] args)
    {
        #region Part 1

        // #region Problem 1
        //Q1 : What is abstraction in OOP? How is it different from encapsulation? Give a real-world example (not from the session) that shows the difference between the two.


        // abstraction is about hiding implementation details
        //encapsulation is about hiding data and controlling access to it


        /*  Different 
        
        1- Abstraction

        A) Hides implementation details
        B) Focuses on what the object does
        c) Achieved using interfaces / abstract classes


        2- Achieved using interfaces / abstract classes
        A) Hides and protects data
        B) Focuses on how to control access to data
        C) Achieved using access modifiers (private, public, etc.)
        
        */


        /*  Example 
        
        Abstraction

        When you use a smartphone:

        You tap an app → it opens
        You make a call → it connects

        You don’t know how the OS, CPU, or network works internally
        This is Abstraction (you use features without knowing implementation)



        Encapsulation:

        Inside the smartphone:

        Internal components (battery data, memory, system files) are hidden
        You cannot directly access or modify them

        You interact through settings or apps only
        This is Encapsulation (data is protected and controlled
        
        
        */
        // #endregion

        // #region Problem 2
        //Q2 : What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?


        /*
        
        1- Abstract

        A) Can have implemented methods + abstract methods
        B) Can Have Fields
        C) Support Constractor 
        D) a Class Can inherit From one Abstract Calss 

        2- Interface
        A) Contains Method Signatures
        B) Can't Have Fields  
        C) Dosn't Have Constractor
        D) a Class Can implement Multiple Interfaces
        
        */


        // when to use 

        /*
        
        1- Abstract 
        A) You have shared code between classes
        B) You want base functionality + some abstraction
        C) There is a strong "is-a" relationship

        2- Interface 
        A) You want to define a contract
        B) No shared implementation needed
        C) Multiple inheritance
        
        */
        // #endregion


        // #region Problem 3

        /*
        

    Q3 : Look at the following code and answer the questions below:public abstract class Appliance
        {

            public string Brand { get; set; }

            protected Appliance(string brand) { Brand = brand; }

            public abstract double PowerConsumption();

            public virtual string Status() => "Standby";

            public string Label() => $"{Brand} - {PowerConsumption()}W";
        }

        public class WashingMachine : Appliance
        {
            public WashingMachine(string brand) : base(brand) { }
            public override double PowerConsumption() => 500;
            public override string Status() => "Washing";
        }

        public class Toaster : Appliance
        {
            public Toaster(string brand) : base(brand) { }
            public override double PowerConsumption() => 800;
        }
        a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
        b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
        c) If you call Status() on a Toaster object, what will it return? Why?

        */

        /*
        
        A ) No , Beacuse we Can't Take an opject From Abstract Class 

        B) PowerConsumption() Must be overridden in derived classes because it is abstract.            
           Status() Can be overridden optionally because it is virtual (has a default implementation).
           Label() Cannot be overridden because it is a non-virtual (concrete) method.

            Why did the designer make each one abstract, virtual, or concrete?
               Abstract must be implemented by all derived classes
                Virtual  has default behavior but can be overridden
                Concrete  fixed implementation, no override needed

c)      C) It returns "Standby" because Toaster does not override Status().
        */ 

        
        // #endregion
        #endregion
    }
}