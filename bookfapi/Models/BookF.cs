using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookfapi.Models{
    public class BookF{
        public int Bid{get;set;}
        public int Fid{get;set;}
        public DateTime Doj{get;set;}
        public int Count{get;set;}
        public int Totalvalue{get;set;}
        public int Cid{get;set;}
    
    public BookF(){

    }
    public BookF(int b,int f,DateTime d,int c,int t,int ci){
        Bid=b;Fid=f;Doj=d;Count=c;Totalvalue=t;Cid=ci;
    }
    public static List<BookF> bf = new List<BookF>();

     public List<BookF> getBDetails()
        {
            // bf.Add(new BookF(123,1,DateTime.Now,2,3000,111));
            // bf.Add(new BookF(124,2,DateTime.Now,1,2500,111));
            return bf;
        }
        public void AddBookF(BookF b)
        {
            bf.Add(b);
        }
        public void DeleteBooking(int id)
        {
            BookF B = GetBookingById(id);
            bf.Remove(B);
        }
        public BookF GetBookingById(int id)
        {
            BookF b = bf.Where(p => p.Bid == id).FirstOrDefault();
            return b;
        }

    }
}