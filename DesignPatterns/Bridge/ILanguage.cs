/*
 * Let's build a bridge 🌉 

The Bridge Pattern is a structural design pattern that 𝐬𝐞𝐩𝐚𝐫𝐚𝐭𝐞𝐬 𝐚𝐧 𝐚𝐛𝐬𝐭𝐫𝐚𝐜𝐭𝐢𝐨𝐧 𝐟𝐫𝐨𝐦 𝐢𝐭𝐬 𝐢𝐦𝐩𝐥𝐞𝐦𝐞𝐧𝐭𝐚𝐭𝐢𝐨𝐧,
allowing the two to evolve independently. This pattern decouples the abstract classes from their
implementation classes by introducing a bridge interface. 

𝐋𝐞𝐭'𝐬 𝐬𝐞𝐞 𝐬𝐨𝐦𝐞 𝐫𝐞𝐚𝐥-𝐰𝐨𝐫𝐥𝐝 𝐞𝐱𝐚𝐦𝐩𝐥𝐞:

Imagine a publishing company that specializes in producing educational books. They have various subjects like Mathematics,
History, and Science. Additionally, they want to publish these books in multiple languages such as English,
Spanish, and French.

The company might end up treating every combination as unique: "English Math book", "Spanish Math book",
"French History book", etc. If they want to introduce a new subject or a new language,
it becomes a cumbersome process of creating new combinations.

With the bridge pattern, they would separate the concept of a "subject" from the "language" in which it's written. 
So, they would develop content for subjects (Math, History, Science) independently of the language. 
Similarly, they'd maintain translation capabilities for each language separately.

When they want to produce a book, they just bridge the subject with the language, creating a combination.

This approach ensures that subjects (like Math and History) and languages (like English and Spanish) evolve independently.
For instance, if a new subject "Geography" is introduced, it can be easily bridged with existing 
languages without having to define translations for each content separately. Similarly,
if a new language like "German" is introduced, existing subjects can be translated to it without modifying
the subject's core content.

 */

namespace Bridge;
public interface ILanguage
{
    string Translate(string content);
}

public abstract class Subject
{
    protected ILanguage language;

    public Subject(ILanguage language) =>
        this.language = language;

    public abstract void DisplayContent();
}

public class Math : Subject
{
    public Math(ILanguage language)
        : base(language) { }

    public override void DisplayContent()
    {
        string content = "This is a book about Mathmatics.";

        Console.WriteLine(language.Translate(content));
    }
}

public class History : Subject
{
    public History(ILanguage language)
        : base(language) { }

    public override void DisplayContent()
    {
        string content = "This is a book about History.";

        Console.WriteLine(language.Translate(content));
    }
}

public class English : ILanguage
{
    public string Translate(string content)
    {
        return content;
    }
}

public class Spanish: ILanguage
{
    public string Translate(string content)
    {
        if (content.Contains("Mathmatics"))
            return "Este es un libro sobre Matemáticas.";
        else if (content.Contains("History"))
            return "Este es un libro sobre Historia.";

        return "Translation not found.";
    }
}

public class French : ILanguage
{
    public string Translate(string content)
    {
        if (content.Contains("Mathmatics"))
            return "Il s'agit d'un livre sur les mathématiques.";
        else if (content.Contains("History"))
            return "C'est un livre sur l'Histoire.";

        return "Translation not found.";
    }
}
