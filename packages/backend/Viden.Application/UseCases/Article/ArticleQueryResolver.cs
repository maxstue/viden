using HotChocolate.Types;

namespace Viden.Application.UseCases.Article;

[ExtendObjectType("RootQueryResolver")]
public class ArticleQueryResolver
{
    public string GetHello() => "Hello world";
}