using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Helpers
{

    // C# in Html sinifi icindeki metodlara kendi metodlarimizi ekleyecegiz
    public static class HtmlHelperExtension
    {
        public static IHtmlContent CustomLabel(this IHtmlHelper htmlHelper, string text, string cssClass)
        {
            var label = "<label class=" + cssClass + ">" + text + "</label>";

            return new HtmlString(label);
        }

        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeholder)
        {
            var textBox = $"<input type='text' name='{name}' value='{value}' placeholder='{placeholder}' class='form-control'></input>";
            return new HtmlString(textBox);
        }


        public static IHtmlContent WissenTextBoxFor<TModel, TProperty>
        (
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression, // odev Expression ne demek bak! (Lambda ile birlikte kullanilan ne varsa o demek)
            string placeholder,
            string cssClass,
            object htmlAttributes
        )
        {
            // var metadata = htmlHelper.ViewData.ModelMetadata.Properties.FirstOrDefault(s => s.PropertyName == ((MemberExpression)expression.Body).Member.Name);
            string name = htmlHelper.NameFor(expression).ToString();
            string value = htmlHelper.ValueFor(expression).ToString();

            var tagBuilder = new TagBuilder("input");
            tagBuilder.Attributes.Add("type", "text");
            tagBuilder.Attributes.Add("name", name);
            tagBuilder.Attributes.Add("value", value);
            tagBuilder.Attributes.Add("placeholder", placeholder);
            tagBuilder.Attributes.Add("class", cssClass);

            return tagBuilder;
        }


    }


    // string sinifinin icine kendi metodumuzu yazalim
    public static class StringExtension
    {
        public static string Reverse(this string value)
        {
            string reString = "";
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reString += value[i];
            }
            return reString;
        }
    }
}


