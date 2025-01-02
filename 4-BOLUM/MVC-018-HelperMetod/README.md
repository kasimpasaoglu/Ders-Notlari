# View Tarafinda Metod Kullanmak

- Razor'da view da metod cagirmak icin sayfa basina metodu yazdgimiz classin namespace'ini giriyoruz -> `@using MyNamespace`
- Daha sonra `@Class.Metod` seklinde yazilarak metod razor icinde cagrilabilir.
- :warning: Bu kullanim icin classlarin ve metodlarin static olmasi gerekir.

---

# Extension Metodlar

- Bir sinifin icine kendi metodumuzu ekleyebilirz

```C#
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
```

- herhangi baska bir class icine yazacagimiz metodta parametre alanina `this` keywordu ile baska sinifi gosterip, oraya metod yazmis oluruz
- Kullanimi;

```C#
string test = "Deneme"
string reversedTest = test.Reverse();
```

Bu yontemle Html classina kendi metodumuzu yazip kendi texbox'umuzu olusturabiliriz

```C#
    public static class HtmlHelperExtension
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeholder)
        {
            var textBox = $"<input type='text' name='{name}' value='{value}' placeholder='{placeholder}' class='form-control'></input>";
            return new HtmlString(textBox);
        }
    }
```

- Artik bir Razor sayfasinda `@Html.` den sonra metodumuzu gorebilecegiz

```C#
@Html.CustomTextBox("UserName", "Username", "Enter Your User Name")
```

## TextBoxFor yazmak

- Razor da lambda operatoruyle olustudugumuz TextBoxFor benzeri bir yapi olusturmak icin, `expression` ile calisacak bir metod yazabiliriz

```C#
public static IHtmlContent WissenTextBoxFor<TModel, TProperty>
    (
        this IHtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TProperty>> expression,
        string placeholder,
        string cssClass,
        object htmlAttributes
    )
    {
        var metadata = htmlHelper.ViewData.ModelMetadata.Properties.FirstOrDefault(s => s.PropertyName == ((MemberExpression)expression.Body).Member.Name);
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
```

- Kullanimi;

```C#
@Html.WissenTextBoxFor(s => s.Name, "Isminizi Giriniz", "form-control", new { OgrenciId = "attribute" })
```

## Expression Ornegi

```C#
        Expression<Func<int, bool>> secondExpression = x => x > 100;

        Func<int, bool> isBigNumber = secondExpression.Compile();

        bool isBig = isBigNumber(110);


        Expression<Func<int, double>> thirdExpression = x => Math.Sqrt(x);

        Func<int, double> square = thirdExpression.Compile();

        double squareResult = square(48);


        Expression<Func<string, string>> reverserExpression = x => x.Reverse();

        Func<string, string> reverser = reverserExpression.Compile();

        string reverserResult = reverser("Kelime");
```
