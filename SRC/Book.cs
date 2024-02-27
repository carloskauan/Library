namespace Library{

  class Book{
    public string NAME;
    public int YEAR;
    private string COD_BOOK;
    public string[][] CLASSIFIC = {new string[3], new string[5]};
    public string AUTHOR;
    public int NUMBER_PAGES;

    public Book(){
      GenerateCodeBook();  
    }

    //Hannler classification
    
    public void GenerateCodeBook() {
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
    
    //Getter e Setter

    public string GetCodBook(){
      return COD_BOOK;
    }



    //StaticS

  }
}
