#include <cstdlib>
#include <iostream>
#include <time.h>
using namespace std;
#define NumberOfPlayers 4
#define TotalRounds 4
void initialFunction();
void gameFunction(int players[]);
int number [24][4]= {{0,1,2,3}, {0,1,3,2}, {0,2,1,3}, {0,2,3,1}, {0,3,1,2}, {0,3,2,1},
    {1,0,2,3}, {1,0,3,2}, {1,2,0,3}, {1,2,3,0}, {1,3,0,2}, {1,3,2,0},
    {2,0,1,3}, {2,0,3,1}, {2,1,0,3}, {2,1,3,0}, {2,3,0,1}, {2,3,1,0},
    {3,0,1,2}, {3,0,2,1}, {3,1,0,2}, {3,1,2,0}, {3,2,0,1}, {3,2,1,0}
}; // random chit generator

struct participants
{
    int character; //
    string c;
    int pointWon;
    int p;
};
participants pl[NumberOfPlayers];


int players[4]= {4,4,4,4};
string ch[NumberOfPlayers]= {"chor", "dakat", "police", "daroga"};
int won[NumberOfPlayers]= {400,600,800,1000};


int points[4]= {0,0,0,0};
int roundsCount = 0;
string finding[2]= {"chor", "dakat"};
int rounds;

int random;
int main()
{
    cout<<"Total Rounds: ";
    cin>> rounds;
    for(int i = 0; i < NumberOfPlayers; i++)
    {
        pl[i].c = ch[i];
        pl[i].character = i;
        pl[i].pointWon = won[i];
        pl[i].p = 10;
    }

    for(int i = 1; i <=  rounds; i++)
    {
        cout<<"Round "<<i<<endl;
        initialFunction();
        gameFunction(players);
        roundsCount++;
        cout<<endl<<"p1: "<<points[0]<<endl<<"p2: "<<points[1]<<endl<<"p3: "<<points[2]<<endl<<"p4: "<<points[3]<<endl;


    }
    return 0;
}
void initialFunction()
{
    srand(time(0));
    random = rand()%24;
    int character [4]= {number[random][0],number[random][1],number[random][2],number[random][3]};

    int p1, p2, p3, p4;
    // cout<<"random: "<<random<<endl<<"c1: "<<character[0]<<endl<<"c2: "<<character[1]<<endl<<"c3: "<<character[2]<<endl<<"c4: "<<character[3]<<endl;

    cout<<"Player "<<(roundsCount+1)%4<<" Choose chit no: ";
    cin>>p1;
    players[(roundsCount+0)%4] = number[random][p1-1];
    cout<<"Player "<<(roundsCount+2)%4<<"  Choose chit no: ";
    cin>>p2;
    players[(roundsCount+1)%4] = number[random][p2-1];
    cout<<"Player "<<(roundsCount+3)%4<<"  Choose chit no: ";
    cin>>p3;
    players[(roundsCount+2)%4] = number[random][p3-1];
    cout<<"Player "<<(roundsCount+4)%4<<"  Choose chit no: ";
    cin>>p4;
    players[(roundsCount+3)%4] = number[random][p4-1];

    //cout<<endl<<"p1: "<<players[0]<<endl<<"p2: "<<players[1]<<endl<<"p3: "<<players[2]<<endl<<"p4: "<<players[3]<<endl;


    for(int i = 0; i < 4; i++)
    {
        if(players[i]==0)
        {
            pl[0].p=i;
        }
        if(players[i]==1)
        {
            pl[1].p=i;
        }
        if(players[i]==2)
        {
            pl[2].p=i;
        }
        if(players[i]==3)
        {
            pl[3].p=i;
        }
    }

}

void gameFunction(int players[])
{

    int choice;
    int findChar=roundsCount%2;
    //cout<<endl<<"p1: "<<ch[players[0]]<<endl<<"p2: "<<ch[players[1]]<<endl<<"p3: "<<ch[players[2]]<<endl<<"p4: "<<ch[players[3]]<<endl<<"find: "<<findChar<<endl;

    cout<<"congratulations player "<<pl[3].p+1<<", You are the Daroga"<<endl;
    points[pl[3].p]+=pl[3].pointWon;


    cout<<"Now player "<<pl[2].p+1<<" is the Police.";

    cout<<" you have to find the " <<finding[findChar]<<endl;


//    if(rand()%2==0)
    if(pl[0].p<pl[1].p)
    {
        cout<<"choose who is "<<finding[findChar]<<". between player " <<pl[0].p+1<<" & player "<< pl[1].p+1 <<": ";
    }
    else
    {
        cout<<"choose who is "<<finding[findChar]<<". between player " <<pl[1].p+1<<" & player "<< pl[0].p+1 <<": ";
    }
    cin>>choice;

    if(findChar==0)
    {

        for(int i = 0; i < 4; i++)
        {
            if(players[i]==findChar)
            {
                if(i+1==choice)
                {
                    cout<<"Congrats, You have found the " <<finding[findChar]<<endl;
                    points[pl[2].p]+=pl[2].pointWon;
                    points[pl[0].p]+=0;
                }
                else
                {
                    cout<<"Ohh, you missed. player "<<pl[0].p+1<<" was the "<<finding[findChar]<<endl;
                    points[pl[2].p]+=0;
                    points[pl[0].p]+=pl[0].pointWon;
                }
            }
            if(players[i]==findChar+1)
            {
                points[pl[1].p]+=pl[1].pointWon;
            }
        }
    }

    else
    {

        for(int i = 0; i < 4; i++)
        {
            if(players[i]==findChar)
            {
                if(i+1==choice)
                {
                    cout<<"Congrats, You have found the " <<finding[findChar]<<endl;
                    points[pl[2].p]+=pl[2].pointWon;
                    points[pl[1].p]+=0;
                }
                else
                {
                    cout<<"Ohh, you missed. player "<<pl[1].p+1<<" was the "<<finding[findChar]<<endl;
                    points[pl[2].p]+=0;
                    points[pl[1].p]+=pl[1].pointWon;
                }
            }
            if(players[i]==findChar+1)
            {
                points[pl[0].p]+=pl[0].pointWon;
            }
        }
    }
}
