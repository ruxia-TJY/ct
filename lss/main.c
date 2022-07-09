#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <dirent.h>
#include <unistd.h>
#include <limits.h>

int readFileList(char *basePath)
{
    DIR *dir;
    struct dirent *ptr;

    if((dir = opendir(basePath)) == NULL){
        perror("Open dir error...\n");
        exit(1);
    }

    while ((ptr = readdir(dir)) != NULL){
        if(strcmp(ptr->d_name,".") == 0 || strcmp(ptr->d_name,"..") == 0)
            continue;

        if(ptr->d_type == DT_DIR){
            printf("/");
        }
        printf("%s\n",ptr->d_name);
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

