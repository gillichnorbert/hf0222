using System;
namespace hf0222
{
	public class SzovegOsszefuzo
    {
		private string szo1;
		private string szo2;

        public SzovegOsszefuzo(string szo1, string szo2)
        {
            this.szo1 = szo1;
            this.szo2 = szo2;
        }

        public string SzoOsszefuzo()
        {
            string osszefuzott = "";

            string rovidebb = szo1.Length <= szo2.Length ? szo1 : szo2;
            string hosszabb = szo1.Length > szo2.Length ? szo1 : szo2;
            

            for (int i = 0; i < rovidebb.Length; i++)
            {
                osszefuzott += szo1[i];
                osszefuzott += szo2[i];
            }



            return osszefuzott + hosszabb.Substring(rovidebb.Length);
        }
    }
}

