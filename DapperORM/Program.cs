using DapperORM;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

IAuthorRepository repo = new AuthorRepository(new SqlConnection(),
    @"Server=COMPUTER01\SQLEXPRESS;Database=Library;Integrated Security=SSPI;");

//var author = repo.Add(new Author() { FirstName = "Neil", LastName = "Gaiman" });
////var author2 = repo.Add(new Author() { FirstName = "Zahid", LastName = "Xelil" });
//Console.WriteLine(author);

//Console.WriteLine(repo.GetById(13));

//repo.Update(new Author { Id = 16, FirstName = "Nadir", LastName = "Zaman" });
//repo.RemoveByIdArray([2, 7, 3, 8]);
//repo.RemoveRange(16, 19);

List<Author> authorList = new()
{
    new Author()
    {
        Id = 1,
        FirstName="sdfsdgsd1",
        LastName="sdfsf1"
    },
        new Author()
    {
        Id=13,
        FirstName="sdfsdgsd2",
        LastName="sdfsf2"
    }
};
repo.UpdateAuthors(authorList);
repo.GetAll().ToList().ForEach(Console.WriteLine);
