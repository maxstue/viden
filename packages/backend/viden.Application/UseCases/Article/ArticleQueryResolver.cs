using HotChocolate.Types;

namespace viden.Application.UseCases.Article;

[ExtendObjectType("RootQueryResolver")]
public class ArticleQueryResolver
{
    public string GetHello() => "Hello world";
}