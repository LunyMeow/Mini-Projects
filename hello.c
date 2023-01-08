#include <stdio.h>

int firstwork(){

printf("Number.:");
int score;
scanf("%d",&score);
printf("Number=%d\n",score);

printf("Float.:");
float fl;
scanf("%f",&fl);
printf("Float=%.2f\n",fl);

char chr;
printf("Char.:");
//scanf("%c",&chr);
scanf(" %c",&chr);
printf("Char=%c\n",chr);

printf("Number + Float %.2f\n",score+fl);
printf("Number - Float %.2f\n",score - fl);
printf("Number * Float %.2f\n",score * fl);
printf("Number / Float %.2f\n",score / fl);
printf("Number %% Float %d\n",score % (int)fl);

printf("1 + Number= %d\n",++score);
--score;

printf("Is equal Number and Float = %d\n",score==(int)fl);

printf("Size of Number = %d\n",sizeof(score));

printf("Is number equal 1? %s\n",(score==1)?"Yes":"No");

printf("Char as ASCII %d",chr);

}
void secondwork(){
int number;
printf("Number.:");
scanf("%d",&number);
if (number%2==0){
printf("Even number");
}
else{
printf("Odd number");
}

}
void thirdwork(){
printf("Loop count?.:");
int a;
scanf("%d",&a);

for (int b=1;b<=a;++b){
printf("%d\n",b);}

while (1){
printf("While loop\n");
break;
}
printf("And do while\n");
do{
}while(0);

char chr;
printf("Char for switch case(a,b,c).:");
scanf(" %c",&chr);
switch(chr){
case 'a':
printf("Its a");
break;

case 'b':
printf("Its b");
break;

case 'c':
printf("Its c");
break;

default:
printf("Hey just write a character i gave you..");
}
printf("\n");

}

void four(){
int sayi1,sayi2;
printf("2 sayi giriniz.:");
scanf("%d %d",&sayi1,&sayi2);
int sayac;
    for(int i = sayi1; i < sayi2; i++)
    {
        sayac = 0;
        for(int j = 2; j < i; j++)
        {
            if(i % j == 0){
                sayac++;
            }
        }
        if(sayac == 0){
            printf("%d sayisi asal bir sayidir.\n",i);
        }
    }
}

int n=5;
void five(){

int array[5]={1,8,3,5,6};
printf("%d\n",sizeof(array) / sizeof(array[0]));
for (int i=0;i<sizeof(array) / sizeof(array[0]);i++){printf("%d\n",array[i]);}
int ages[4];
printf("Enter 4 age.:?");
scanf("%d %d %d %d",&ages[0],&ages[1],&ages[2],&ages[3]);
float sum=0.0,top=0;
for (int i=0;i<4;i++){top+=ages[i];}
printf("Sum of ages.:%.3f\n",(float)top/4.0);

}

void six(){ //Matris
printf("Enter r and c.:");
int row,co;
scanf("%d %d",&row,&co);
int a[row][co];
int i=0,b=0,sayac=0;
for (i=0;i<row;i++){
for (b=0;b<co;b++){
sayac++;
printf("[v%d]  ",sayac);


}
printf("\n");

}


int r=0;
int c=0;
for (i=1;i<row*co+1;i++){printf(" v%d..:",i);scanf("%d",&a[r][c]);c++;if (i>co-1 && i<co*2-1){r=1;}else if (i>co*2-1 && i<co*3-1){r=2;} if (i==co){c=0;}else if (i==co*2){c=0;}}
//printf("[%d] [%d] [%d]\n[%d] [%d] [%d]\n[%d] [%d] [%d]\n",);
r=0;
c=0;
for (i=0;i<row;i++){
for (b=0;b<co;b++){
printf("[%d]  ",a[i][b]);

}
printf("\n");
}
}

int main(){
printf("Works(1,2,3,4,5,6)?.:");
char a;
scanf("%c",&a);
if (a=='1'){firstwork();}
else if (a=='2'){secondwork();}
else if (a=='3') {thirdwork();}
else if (a=='4') {four();}
else if (a=='5') {five();}
else if (a=='6') {six();}
return 0;
}
