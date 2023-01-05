namespace MyWebsite.User;

public class Result{



public string gender { get; set;}

public Name name { get; set;}

public picture picture { get; set;}

public Location location { get; set;}

public string email { get; set;}
}

public class Name  {

    public string first  {get; set;}

      public string last {get; set;}


}

public class Location{


    public string city {get; set;}

        public string country {get; set;}

}
public class picture  {

    public string large  {get; set;}

      public string thumbnail {get; set;}


}



public class Root
{

public List <Result> results{get;set;}


}
  
  public class RandomUser{

    public static async Task<Root?> GetResultsAsync()
    {

    var client = new HttpClient();

    var response = await client.GetFromJsonAsync<Root?>("https://randomuser.me/api/");

    
     

    return response;


    }
  }
