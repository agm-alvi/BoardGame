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
int main() {

//int points[4]={0,0,0,0};
//int rounds = 0;

srand(time(0));
int random = rand()%24;
int character [4]= {number[random][0],number[random][1],number[random][2],number[random][3]};

int players[4]={4,4,4,4};
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
players[0] = character[in];
cout<<"choose player 2: ";
cin>>p2;
players[1] = character[in];

cout<<"choose player 3: ";
cin>>p3;
players[2] = character[in];

cout<<"choose player 4: ";
cin>>p4;
players[3] = character[in];

cout<<endl<<"p1: "<<players[0]<<endl<<"p2: "<<players[1]<<endl<<"p3: "<<players[2]<<endl<<"p4: "<<players[3]<<endl;
gameFunction(players);
    return 0;
}


void gameFunction(int players[]){

string c[4]={"chor", "dakat", "police", "daroga"};

cout<<endl<<"p1: "<<players[0]<<endl<<"p2: "<<players[1]<<endl<<"p3: "<<players[2]<<endl<<"p4: "<<players[3]<<endl;
}
