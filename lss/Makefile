TARGET=lss
CC=gcc
Build=../bin/

TARGET_PATH=$(Build)$(TARGET)

$(TARGET):main.c
	$(CC) -o $(TARGET_PATH) $^

.PHONY:clean
clean:
	-rm $(TARGET_PATH)

