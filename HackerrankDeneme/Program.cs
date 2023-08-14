string s = "12:05:45PM";
string saat = s.Substring(0, 2);
string dakika = s.Substring(3, 2);
string saniye = s.Substring(6, 2);
string AmOrPm = s.Substring(8, 2);
if (AmOrPm == "AM" && saat == "12")
{
    saat = "00";
    //return saat + ":" + dakika + ":" + saniye;
}

else if (AmOrPm == "PM" && saat == "12")
{
    int pırt = Convert.ToInt32(saat);
    pırt -= 12;
    saat = pırt.ToString();
    //return saat + ":" + dakika + ":" + saniye;
}
else
{
    int zort = Convert.ToInt32(saat);
    zort += 12;
    saat = zort.ToString();
    //return saat + ":" + dakika + ":" + saniye;
}