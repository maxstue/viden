using HotChocolate.Types;

namespace Application.UseCases.Article;

[ExtendObjectType("RootQueryResolver")]
public class ArticleQueryResolver
{
    public string GetHello() => "Hello world";
}