//
// Created by r on 22-7-9.
//

#ifndef TCOLORPC_H
#define TCOLORPC_H

#include<stdio.h>

struct pColor
{
    int foreColor;
    int backColor;
    int method;
};

extern void printColor(struct pColor *color);
extern void printNormal();
extern void printGreen();
extern void printBlue();
extern void printCyan();


#endif //TCOLORPC_H
