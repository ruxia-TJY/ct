#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <dirent.h>
#include <unistd.h>
#include <limits.h>
#include "include/tColorPC.h"

int readFileList(char *basePath)
{
    DIR *dir;
    struct dirent *ptr;

    if((dir = opendir(basePath)) == NULL){
        perror("Open dir error...\n");
        exit(1);
    }

    while ((ptr = readdir(dir)) != NULL){
        printNormal();
        if(strcmp(ptr->d_name,".") == 0 || strcmp(ptr->d_name,"..") == 0)
            continue;

        if(ptr->d_type == DT_DIR){
            printBlue();
            printf("%s",ptr->d_name);
            printNormal();
            printf("/\n");
        }
        else if(ptr->d_type == DT_LNK){
            printCyan();
            printf("%s\n",ptr->d_name);
        }
        else{
            if(access(ptr->d_name,X_OK)==0){
                printGreen();
            }
            printf("%s\n",ptr->d_name);
        }
    }
    closedir(dir);

    return 1;
}

int main(int argc,char**argv)
{
    char pathBuf[PATH_MAX];
    getcwd(pathBuf,sizeof(pathBuf));

    readFileList(pathBuf);
    return 0;
}