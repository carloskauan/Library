namespace Library{
  class Book{
    private string NAME;
    private int YEAR;
    public string COD_BOOK;
    public string[][] CLASSIFIC = {new string[3], new string[5]};
    private string AUTHOR;
    private int NUMBER_PAGES;

    public Book(){
      System.Console.Write("\nNOME>>");
      NAME = Console.ReadLine();

      System.Console.Write("\nYEAR>>");
      YEAR = int.Parse(Console.ReadLine());

      GenerateCodeBook();

      DefineClassification();

      System.Console.Write("\nAUTHOR>>");
      AUTHOR = Console.ReadLine();

      System.Console.Write("\nNUMBER OF PAGES>>");
      NUMBER_PAGES = int.Parse(Console.ReadLine());

      ShowData();    
    }

    //Hannler classification
    private void DefineClassification(){
      foreach (var item in CLASSIFIC){
        if(item.Length <= 3)
          System.Console.WriteLine("GENERO");
        else
          System.Console.WriteLine("TAGS");
        for(int i = 0; i < item.Length; i++){
          System.Console.WriteLine($"{i+1}>>");
          item[i] = Console.ReadLine();
        }
      }
    }
    
    public void GenerateCodeBook(){
      Random random = new Random();
      int[] randDigits = new int[10];
      for(int i = 0; i < randDigits.Length; i++){
        randDigits[i] = random.Next(0,9);
      }
      COD_BOOK = String.Join("", randDigits);
    }

    public void ShowData(){
      System.Console.WriteLine("\n");
      System.Console.WriteLine($"Name: {NAME}");
      System.Console.WriteLine($"Year: {YEAR}");
      System.Console.WriteLine($"Code of book: {COD_BOOK}");
      ShowClassification();
      System.Console.WriteLine($"Author: {AUTHOR}");
      System.Console.WriteLine($"Number of pages: {NUMBER_PAGES}");
    }
    private void ShowClassification(){
      foreach (var classf in CLASSIFIC){
        if(classf.Length <= 3)
          System.Console.WriteLine("Genders:");
        else
          System.Console.WriteLine("Tags:");
        foreach (var item in classf){
          System.Console.Write($"{item} ");
        }
        System.Console.WriteLine("");
      }
    }
  }
}
