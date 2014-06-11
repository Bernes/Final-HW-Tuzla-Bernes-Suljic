class Person
{
    private string lastName;
    public string name;

    //when we Modify the Person class and Add count property we then can count the
    //number of the "Person" objects created. 

    private static int _count = 0;

    public static int count
    {
        get //the get is public because it wants the user to see it.
        {
            return _count;
        }

        private set //the set is private because its hideing itself from the user.
        {
            _count = value;
        }
    }

    Person(string name, string lastName)
    {
        this.name = name;
        this.lastName = lastName;
        // the "count++" is needed for counting all of the created
        //Person objects that we inserted up top.
        count++;

    }
    protected string getPersonInfo() { return name + ", " + lastName; }
};