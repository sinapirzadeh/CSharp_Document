string text = " salam Man sina pirzadeh Hastam ";

//for Show number of yor text;
int len = text.Length;
//for Show on in this renge of number you enter;
string sub = text.Substring(0, 6);
//for dont Show on in renge of number you enter;
string rem = text.Remove(0, 6);
//for tolower all text;
string lower = text.ToLower();
//for toupper all text;
string upper = text.ToUpper();
//for chek your enter string in text;
bool con = text.Contains("sina");
//for delete all spece is yor text;
string trim = text.Trim();
//for chench your enter string in thet string in text;
string rep = text.Replace("sina", "amir");


//for exampel worket;
Console.Write(len);
Console.Write(sub);
Console.Write(lower);
Console.Write(upper);
Console.Write(con);
Console.Write(trim);
Console.Write(rep);

