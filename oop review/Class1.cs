using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_review
{
    //Private Data members 
    //these are variables that are known ONLY within the class
    //will be used for FULLY implemented Properties
    //will be used for class only data

    

    //Public data members
    //these are variables that are lnown within the class and outside of the class
    //public data members can be altered within and without side of the class
    //it is preffered ti use PRoperties instead of public data members 

    //Properties
    //optional
    //properties can be implemented in two ways
    //A) fully implemented property
    //used because there is additional code/logic use in processing the data
    //B) auto implemented property
    // used when there is no need for additional code/logic
    //when the data is simply saved/stored
    //Constructors

    //Behaviours
    class Window
    {
        private string puppy;
        private decimal _Height;

        public string Manufactor
        {
            
        //assume the manufacturer is a nullable string 
        //3 possibilities
        //A) there are characters
        //B) string has no data (null)
        //C) there is a physical string BUT NO characters
        //there will be additional code/logic to ensure ONLY A and B exists for the data
        //and a property to manage the data content
        get
            {
                //returns data via the property to the outside user of that property
                // a get operates on the rigt side of an equal sign

            }
            set
            {
                //the set takes incoming data and places that data into a private data member
                //internal to the property, incoming data will be placed in a common variable called value
                //a property is associated with a single data member
                //a property has NO parameter list
                //a set opperates on the left side of an equal sign(assignment statement)

                if (string.IsNullOrEmpty(value))
                {
                    //ensure a null is stored in the private data member
                    puppy = null;
                   //case b
                }
                else 
                {
                    //ensure the value is stored in the private data member
                    puppy = value;
                    //case a
                }

                //alternative coding
                //syntax    recieving field = conditons(s) ? true value : false value;
                // puppy = string.IsNullOrEmpty(value) ? null : value;
                    //can only be used for a single value being returned
                
            }
   

        }
        public decimal Height
        {
            //Height must be greater than 0
            get { return _Height; }
            set
            {
                //the m indicates the value is a deciaml 
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0.");
                }
                else
                {
                    _Height = value;
                }
            }
       
        }
     // auto implemented properties can be used when there is NO NEED for additional processing against the incoming data
     //NO internal private data member is required for this property
     //the system WILL internally generate a data rea for the data 
     //accessing the stored data (get, set) CAN ONLY be done via the property

        public decimal Width { get; set; }
        //one can still code auto implemented properties as fully implemented properties

        //private deciaml _Width;
        //public deciaml Width
        //{
        //  get { return _Width; }
        //  set { _Width = value; }
        //}

        //waht about nullable numerics
        //do we need to test for a null value to be used for missing incoming data
        //NO, you do not have to code a fully implemented property for a nullable numeric
        //numerics have a default of 0
        //numerics CAN ONLY store a numeric (unless nullable)
        //numerics CAN BE NULL if declared as nullable 
        //IF the numeric has a additional criteria THEN you can code the property as a FULLY IMPLEMENTED property
        public int? NumberOfPanes { get; set; }
        //constructors

        //Behaviours
    }

}
