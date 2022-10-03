#include <cstdlib>
#include <iostream>
#include <time.h>
using namespace std;

void gameFunction(int players[]);
int number [24][4]= {{0,1,2,3}, {0,1,3,2}, {0,2,1,3}, {0,2,3,1}, {0,3,1,2}, {0,3,2,1},
                    {1,0,2,3}, {1,0,3,2}, {1,2,0,3}, {1,2,3,0}, {1,3,0,2}, {1,3,2,0},
                    {2,0,1,3}, {2,0,3,1}, {2,1,0,3}, {2,1,3,0}, {2,3,0,1}, {2,3,1,0},
                    {3,0,1,2}, {3,0,2,1}, {3,1,0,2}, {3,1,2,0}, {3,2,0,1}, {3,2,1,0}
                    };

int players[4]={4,4,4,4};
int thief, robber, police;
string c[4]={"chor", "dakat", "police", "daroga"};
string finding[2]={"chor", "dakat"};
int points[4]={0,0,0,0};
int rounds = 0;
int main() {



srand(time(0));
int random = rand()%24;
int character [4]= {number[random][0],number[random][1],number[random][2],number[random][3]};

int p1, p2, p3, p4;

/*
p1 = number[random][0];
p2 = number[random][1];
p3 = number[random][2];
p4 = number[random][3];

//cout<<"random: "<<random<<endl<<"p1: "<<p1<<endl<<"p2: "<<p2<<endl<<"p3: "<<p3<<endl<<"p4: "<<p4<<endl;
*/
int in;
cout<<"random: "<<random<<endl<<"c1: "<<character[0]<<endl<<"c2: "<<character[1]<<endl<<"c3: "<<character[2]<<endl<<"c4: "<<character[3]<<endl;

cout<<"choose player 1: ";
cin>>p1;
players[0] = character[p1];
cout<<"choose player 2: ";
cin>>p2;
players[1] = character[p2];

cout<<"choose player 3: ";
cin>>p3;
players[2] = character[p3];

cout<<"choose player 4: ";
cin>>p4;
players[3] = character[p4];

cout<<endl<<"p1: "<<players[0]<<endl<<"p2: "<<players[1]<<endl<<"p3: "<<players[2]<<endl<<"p4: "<<players[3]<<endl;
gameFunction(players);
    return 0;
}


void gameFunction(int players[]){

int choice;
int findChar=rounds%2;
cout<<endl<<"p1: "<<c[players[0]]<<endl<<"p2: "<<c[players[1]]<<endl<<"p3: "<<c[players[2]]<<endl<<"p4: "<<c[players[3]]<<endl<<"find: "<<findChar<<endl;

for(int i = 0; i < 4; i++){
    if(players[i]==3){
            points[i]+=1000;
        cout<<"congratulations player "<<i+1<<", You are the Daroga"<<endl;
    }
}

for(int i = 0; i < 4; i++){
    if(players[i]==2){
            police=i;
        cout<<"Now player "<<i+1<<" is the Police. Now you have to find the " <<finding[findChar]<<endl;
    }
}
cout<<"choose who is "<<finding[findChar]<<":";
cin>>choice;

for(int i = 0; i < 4; i++){
    if(players[i]==findChar){
        if(i+1==choice){
        cout<<"Congrats, You have found the " <<finding[rounds%2]<<endl;
        points[police]+=800;
points[i]+=0;
        }
        else{
            cout<<"Ohh, you missed"<<endl;
            points[police]+=000;
points[i]+=400;
        }
    }
    if(players[i]==findChar+1){
        points[i]+=600;
    }
}


cout<<endl<<"p1: "<<points[0]<<endl<<"p2: "<<points[1]<<endl<<"p3: "<<points[2]<<endl<<"p4: "<<points[3]<<endl;

}
