objects = p/p.o
targets = build bin/p

.PHONY: all
all:$(targets)

# 创建文件夹
build:
	-mkdir bin
	-mkdir obj

# 编译
bin/p: $(objects)
	-cc -o bin/p $(objects)

p.o : p.c
	cc -c p.c


.PHONY: clean
clean:
	-rm $(objects)
	-rm $(targets)
	-rm -rf bin
	-rm -rf obj