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
        #endregion
    }
}