using HotChocolate.Types;

namespace Kj.Application.UseCases.Article;

[ExtendObjectType("RootQueryResolver")]
public class ArticleQueryResolver
{
    public string GetHello() => "Hello world";
}