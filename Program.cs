namespace Library{
  class Program{

    private static Library library = new Library();

    static void Main(string[] args){
      while(true){
        Console.Clear();
        ShowEntryOptions();
      }
    }

    static void ShowStaffOptions(){
      Console.Clear();
      System.Console.Write("Press:\n1\t-\tRegister title\n2\t-\tRemove title\n3\t-\tView Stock\n4\t-\tEdit Stock>>");
      switch(int.Parse(Console.ReadLine())){
          case 1:
            try {
              Book book = GetBookData();
              library.RegisterTitle(book);
            } catch(Exception e) {
              System.Console.WriteLine(e.Message); 
              Console.ReadLine();
            }
            break;
          case 2:
            //Remove title
            break;
          case 3:
            //View Stock
            break;
          case 4:
            //Edit Sotck
            break;
          case 0:
            System.Environment.Exit(0);
            break;
          default:
            System.Console.WriteLine("Invalid Option");
            break;
      }
    }

    static void ShowEntryOptions(){
      System.Console.WriteLine("Wellcome to CEOS BooKing");
      System.Console.Write("Press:\n1\t-\tIf you cliente\n2\t-\tIf you staff\n0\t-\tTo exit\n>>");
      switch(int.Parse(Console.ReadLine())){
          case 1:
            //Cliente oprations
            break;
          case 2:
            ShowStaffOptions();
            break;
          case 3:
            library.ShowCatalogy();
            break;
          case 0:
            System.Environment.Exit(0);
            break;
          default:
            System.Console.WriteLine("Invalid Option");
            break;
      }
    }


    private static Book? GetBookData() {
      Book book = new Book();

      System.Console.Write("\nNOME>>");
      book.NAME = Console.ReadLine();

      if (library.VerifyExistence(book.NAME)) {
        throw new Exception("Livro já existe.");
      }

      System.Console.Write("\nYEAR>>");
      book.YEAR = int.Parse(Console.ReadLine());

      foreach (var item in book.CLASSIFIC){
        if(item.Length <= 3)
          System.Console.WriteLine("GENERO");
        else
          System.Console.WriteLine("TAGS");
        for(int i = 0; i < item.Length; i++){
          System.Console.WriteLine($"{i+1}>>");
          item[i] = Console.ReadLine();
        }
      }

      System.Console.Write("\nAUTHOR>>");
      book.AUTHOR = Console.ReadLine();

      System.Console.Write("\nNUMBER OF PAGES>>");
      book.NUMBER_PAGES = int.Parse(Console.ReadLine());

      return book;
    }
  }
}