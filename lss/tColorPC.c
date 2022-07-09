//
// Created by r on 22-7-9.
//
#include "tColorPC.h"

void printColor(struct pColor *color)
{
    int flag = 0;
    if(color->method == -1)flag += 1;
    if(color->foreColor == -1)flag += 2;
    if(color->backColor == -1)flag += 4;

    switch (flag) {
        case 0:
            printf("\033[%d;%d;%dm",color->method,color->foreColor,color->backColor);
            break;
        case 1:
            printf("\033[%d;%dm",color->foreColor,color->backColor);
            break;
        case 2:
            printf("\033[%d;%dm",color->method,color->backColor);
            break;
        case 4:
            printf("\033[%d;%dm",color->method,color->foreColor);
            break;
        case 3:
            printf("\033[%dm",color->backColor);
            break;
        case 5:
            printf("\033[%dm",color->foreColor);
            break;
        case 6:
            printf("\033[%dm",color->method);
            break;
    }
}


void printNormal()
{
    struct pColor color;
    color.method = 0;
    color.foreColor = -1;
    color.backColor = -1;
    printColor(&color);
}

void printGreen()
{
    struct pColor color;
    color.method = -1;
    color.foreColor = 32;
    color.backColor = -1;
    printColor(&color);
}

void printBlue()
{
    struct pColor color;
    color.method = -1;
    color.foreColor = 34;
    color.backColor = -1;
    printColor(&color);
}

void printCyan()
{
    struct pColor color;
    color.method = -1;
    color.foreColor = 36;
    color.backColor = -1;
    printColor(&color);
}
