using System;

namespace C__OOP_assignment
{
  class Program
  {
    class Painting {
      //Class with four properties and one abstract method, describe().
      private string name;
      public string Name {
        get { return name; }
        set { name = value; }
      }
      private string painter;
      public string Painter {
        get { return painter; }
        set { painter = value; }
      }
      private string medium;
      public string Medium {
        get { return medium; }
        set { medium = value; }
      }
      private int year;
      public int Year {
        get { return year; }
        set { year = value; }
      }
      //Abstract method, to be implemented individually for each sub-class.
      public virtual string describe() {
        return "";
      }
    }
    class OilPainting : Painting {
      //Use auto-implemented property to set medium to read-only value of "oil" in this class
      //and hide the property of the base, painting, class.
      public new string Medium {get;} = "oil";
      //New property for this class.
      private string support;
      public string Support {
        get { return support; }
        set { support = value; }
      }
      //describe method overrides the abstract method of the base class.
      public override string describe() {
        return $"{this.Name} by {this.Painter}, oil on {this.Support}, {this.Year}.";
      }
    }
    class Fresco : Painting {
      //Use auto-implemented property to set medium to read-only value of "fresco" in this class
      //and hide the property of the base, painting, class.
      public new string Medium {get;} = "fresco";
      //New property for this class.
      private string location;
      public string Location {
        get { return location; }
        set { location = value; }
      }
      //describe method overrides the abstract method of the base class.
      public override string describe() {
        return $"{this.Name} by {this.Painter}, fresco in {this.Location}, {this.Year}.";
      }
    }
    class Watermedia : Painting {
      //Use auto-implemented property to set medium to read-only value of "watermedia" in this class
      //and hide the property of the base, painting, class.
      public new string Medium {get;} = "watermedia";
      //New property for this class.
      private string type;
      public string Type {
        get { return type; }
        set { type = value; }
      }
      //describe method overrides the abstract method of the base class.
      public override string describe() {
        return $"{this.Name} by {this.Painter}, {this.Type} type watermedia, {this.Year}.";
      }
    }
    class OtherPainting : Painting {
      //Note medium property from base class retained in this sub-class as it is still appropriate
      //("Other" type painting will need to have the medium type defined. )
      //New property for this class.
      private string typeDescription;
      public string TypeDescription {
        get { return typeDescription; }
        set { typeDescription = value; }
      }
      //describe method overrides the abstract method of the base class.
      public override string describe() {
        return $"{this.Name} by {this.Painter}, {this.Medium} {this.TypeDescription}, {this.Year}.";
      }
    }
    static void Main(string[] args)
    {
        OilPainting monaLisa = new OilPainting();
        monaLisa.Name = "Mona Lisa";
        monaLisa.Painter = "Leonardo da Vinci";
        //The following line will give an error if uncommented. Medium is read-only for this class.
        //monaLisa.Medium = "oil";
        monaLisa.Year = 1503;
        monaLisa.Support = "canvas";
        Console.WriteLine( monaLisa.describe() );
        //The medium can be read.
        Console.WriteLine( monaLisa.Medium );

        Fresco theCreationOfAdam = new Fresco();
        theCreationOfAdam.Name = "The Creation of Adam";
        theCreationOfAdam.Painter = "Michelangelo";
        theCreationOfAdam.Location = "the Sistine Chapel";
        theCreationOfAdam.Year = 1512;
        Console.WriteLine( theCreationOfAdam.describe() );
        Console.WriteLine( theCreationOfAdam.Medium );

        Watermedia lagoDAverno = new Watermedia();
        lagoDAverno.Name = "Lago d'Averno";
        lagoDAverno.Painter = "Jacob Philipp Hackert";
        lagoDAverno.Type = "gouache";
        lagoDAverno.Year = 1794;
        Console.WriteLine( lagoDAverno.describe() );
        Console.WriteLine( lagoDAverno.Medium );

        OtherPainting campbellsSoupCans = new OtherPainting();
        campbellsSoupCans.Name = "Campbell's Soup Cans";
        campbellsSoupCans.Painter = "Andy Warhole";
        //Medium can be set for the OtherPainting class.
        campbellsSoupCans.Medium = "synthetic polymer";
        campbellsSoupCans.TypeDescription = "screen print";
        campbellsSoupCans.Year = 1962;
        Console.WriteLine( campbellsSoupCans.describe() );
        Console.WriteLine( campbellsSoupCans.Medium );
    }
  }
}
