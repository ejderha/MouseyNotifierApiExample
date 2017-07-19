using System;
using System.Reflection;

namespace Forservices.MOUSEY.Notifier.WebAPI.Example.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}