package TwitterTowers;
import java.util.Scanner;
public class TwitterTowers {
    public static void rectangle(int num, int hight, int width){
        if(Math.abs(hight-width)>5||hight==width)
           System.out.println("The area of your rectangular tower is: "+hight*width);
        else
           System.out.println("The perimeter of your rectangular tower is: "+(hight+width)*2);  
    }
    
    public static void triangle(int num, int hight, int width){
        Scanner in = new Scanner(System.in);
        System.out.println("Press 1 or 2 (1 - perimeter, 2 - area)");
        int chooseTr=in.nextInt();
        switch(chooseTr){
              case 1:
                   System.out.println("The perimeter of your triangle tower is: "+(hight*2+width));
                   break;
              case 2:
                   if(width%2==0||width>hight*2){
                     System.out.println("We're sorry, but your triangle tower cannot be printed :(");
                     break;
                   }
                   else if(width%2!=0&&width<hight*2){
                          int oddNums=width/2+1;
                          String space="";
                          String stars="*";
                          //הדפסת שורות המשולש
                          System.out.println("your choose: triangle tower - hight: "+hight+ " width: "+width);
                          System.out.println("");
                          for (int k = 0; k < width/2; k++) {
                               space+=" ";
                          }  
                          int countLines = oddNums!=2? (hight-2)/(oddNums-2): 2;
                          int bonus=hight>2?(hight-2)%(oddNums-2):0;
                          //מספר הקבוצות שמדפיס בסך הכל
                          for (int i = 1; i <= oddNums; i++) {
                               //מספר השורות בכל קבוצה
//                               int countLines = i==2? (hight-2)/oddNums+(hight-2)%oddNums:(hight-2)/oddNums;
                                int lines=0;
                                if(i==1||i==oddNums)
                                    lines=1;
                                else if(i==2)
                                    lines=countLines+bonus;
                                else
                                    lines=countLines;
                                for (int j = 0; j < lines; j++) {
                                    //מספר הכוכביות בכל שורה
                                    System.out.print(space);
                                    System.out.println(stars);
                                } 
                          stars+="**";
                          space = space.length()!=0? space.substring(1):space;
                          }
                   }
                   System.out.println("");
                   break;
                   default: 
                          System.out.println("You only need to dial the numbers 1 or 2");
                          break;
        }
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int num=0,hight=0,width=0;
        System.out.println("enter a number from 1 to 3 (1 - rectangle, 2 - triangle, 3 - exit");
        num=in.nextInt();
        //התכנית תרוץ ותתן לו את האפשרויות לבחור בין שתי האפשרויות עד שיקיש את הספרה שלוש
        while (num!=3){
            //במקרה שהקיש ספרה שאינה מתאימה לכללי התכנית
            if(num!=1&&num!=2){
                System.out.println("You only need to type a number between 1 and 3");
                System.out.println("enter a number from 1 to 3 (1 - rectangle, 2 - triangle, 3 - exit)");
                num=in.nextInt();
            }
            System.out.println("enter your tower height");
            hight=in.nextInt();
            //במקרה שהקיש גובה נמוך מידי
            while(hight<2){
                System.out.println("The height you pressed is too low, press again please");
                hight=in.nextInt();
            }
            System.out.println("enter your tower width");
            width=in.nextInt();
            //כעת מדובר במלבן
            if(num==1){
                rectangle(num, hight, width);
            }
            //כעת מדובר במשולש
            else {
                 triangle(num, hight, width);
            }
        System.out.println("enter a number from 1 to 3 (1 - rectangle, 2 - triangle, 3 - exit");
        num=in.nextInt();    
        }
        System.out.println("We enjoyed being together :)");
    }
}
