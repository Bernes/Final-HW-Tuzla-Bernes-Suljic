using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student : Person, IComparable<Student>
{
    //This is to the Add automatic property of 
    //the email that we use or type in

    public string email { get; set; }

    private string location;

    //the lines under is to Complete setName mathod to check if string will work and is valid.
    //If it is then set the name field and return true

    public bool setName(string input)
    {
        if (input.Length < 3)
        {
            Console.WriteLine("The name must be a minimum of three characters long!");
            return false;
        }//the line under basically states that the name must begin with an uppercase letter 
        //inorder to be valid and let the user continue
        if (input.Substring(0, 1) == input[0].ToString().ToUpper())
        {
            Console.WriteLine("The ame must begin with an uppercase letter!!"); return false;
        }




        //basically states that no numbers not symbols can be put in the text instead only letters.
        if (!input.All(Char.IsLetter))
        {
            Console.WriteLine("The name can only have letters, no symbols/numbers!");
            return false;
        }

        name = input;
        return true;
    }
    // Write getStudentInfo to return students name, lastName, email and location
//in that order because it's set that way.

    public string getStudentInfo()
    {
        return getPersonInfo() + ", " + email + ", " + location;
    }

    public string Location  // That is the location proprety
    {
        set // this is the "set" of the public string.
        {

            if (value == "TZ" || value == "Tuzla" || value == "TUZLA")
                location = "TZ";

 if (value == "SA" || value == "Sarajevo" || value == "SARAJEVO")
                location = "SA";
            location = "NotAssociated";
        }

        get //this is the "GET" of the public string.
        {
            if (location == "TZ") return "Tuzla"; 
            if (location == "SA") return "Sarajevo";

            return "NotAssociated";

        }
    }
    public Student() : base("Bernes", "Suljic") { this.email = "bssc1223@aubih.edu.ba"; this.location = "Tuzla"; }

    //This section is meant to Write the Student constructor that takes in 
    //3 string arguments name, lastName, email and lets the program recognize it

    public Student(string name, string lastName, string email)
        : base(name, lastName)
    {
        this.email = email;
    }

    //Just to basically Write the Student that takes in
    //3 "string" arguments name, lastName, location

    public Student(string name, string lastName, string location)
        : base(name, lastName)
    {
        this.location = location;
    }

    //Here belongs the parameterless constructor
    public Student()
        : base()
    {

    }

    //when I used Implement "IComparable" its so that Students can be sorted
    //by location in following order

    public int CompareTo(Student b)
    {
        // Alphabetical order
        return this.name.CompareTo(b.name);
    }


    ~Student()
    {

    }

    //this is to Override ToString() and go the method that returns Student info 
   //(return same value as getStudentInfo)

    public override string ToString()
    {
        return getStudentInfo();
    }



}