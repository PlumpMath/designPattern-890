#include <iostream>
#include <string>
#include <utility>
#include "Singleton.h"

using namespace std;

struct A
{
    A(const string&){cout<<"lvalue"<<endl;}
    A(string&& x){cout<<"rvalue"<<endl;}
};

struct B
{

    B(const string&){cout<<"lvalue"<<endl;}
    B(string&& x){cout<<"rvalue"<<endl;}
};

struct C
{

    C(int x, double y){}
    void Fun(){cout<<"Test"<<endl;}
};

int main()
{
    string str = "bb";

    //创建A类型的单例
    Singleton<A>::Instance(str);

    //创建B类型的单例，临时变量str被move之后变成右值
    Singleton<B>::Instance(std::move(str));

    //创建C类型的单例，含两个参数
    Singleton<C>::Instance(1, 3.14);

    //获取单例病调用单例对象的方法
    Singleton<C>::GetInstance()->Fun();

    Singleton<A>::DestroyInstance();
    Singleton<B>::DestroyInstance();
    Singleton<C>::DestroyInstance();
    //return 0;
}
