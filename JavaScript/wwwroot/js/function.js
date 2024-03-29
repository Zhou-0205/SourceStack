﻿//构建一个函数has9(number) ，可以判断number中是否带有数字9；
function has9(number) {
    var regex = new RegExp("[9]");
    return regex.test(number);
}
//has9();

//构建一个函数has8(number) ，可以判断number中是否带有数字8；
function has8(number) {
    var regex = new RegExp("[8]");
    return regex.test(number);
}
//has8();

//构建一个函数has6(number) ，可以判断number中是否带有数字6；
function has6(number) {
    var regex = new RegExp("[6]");
    return regex.test(number);
}
//has6();

//让get986()通过调用has9() / has8() / has6() ，能找出number以内有多少个数字包含：9或者8或6
//var numbers = [343, 888, 657, 777, 365, 234, 798, 456, 987];
//var amount = 0;
function get986(number) {
    for (var i = 0; i < number.length; i++) {
        if (has9(number[i]) || has8(number[i]) || has6(number[i])) {
            //amount++;
            return true;
        }//else nothing
    }
}
//get986();

//将之前“找出素数”的代码封装成一个函数findPrime(max) ，可以打印出max以内的所有素数。
function findPrime(max) {
    for (var i = 0; i < max.length; i++) {
        for (var j = 0; j < i; j++) {
            if (i % j === 0) {
                break;
            }
            if (i - 1 === j) {
                console.log(i);
            }
        }
    }
}

//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
function Sum(start, step) {
    for (var i = start; i < 100; i += step) {
        start += step;
    }
    console.log(start);
}
Sum(5, 5);

//封装一个函数swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
var arrary = [23, 34, 45, 56, 67, 78];
function swap(arrary, i, j) {
    var temp;
    temp = arrary[i];
    arrary[i] = arrary[j];
    arrary[j] = temp;
}
swap(arrary, 2, 4);

//封装函数deleteDuplicated()删除一个数组里面重复的元素
var arr = [14, 25, 32, 45, 23, 56, 23];
function deleteDuplicated(arr) {
    var newarr = [];
    for (var i = 0; i < arr.length; i++) {
        if (newarr.indexOf(arr[i]) === -1) {
            newarr.push(arr[i]);
        }
    }
    return newarr;
}
deleteDuplicated(arr);

//不使用JavaScript内置函数将一个字符串顺序颠倒
//比如：'hello,yuanzhan' 变成 'nahznauy,olleh'
var string = 'hello,yuanzhan';
var newstr = '';
function perversion(string) {
    for (var i = string.length - 1; i >= 0; i--) {
        newstr += string[i];
    }
    console.log(newstr);
}
perversion(string);

//统计出这段文字中有多少个单词：
var paragraph = "There are two ways to create a RegExp object: a literal notation and a constructor.To indicate stringsthe parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression"
var amount = 1;
function myfunction(arr) {
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === ' ' || arr[i] === '.' || arr[i] === ':') {
            if ((arr[i - 1] >= 'a' && arr[i - 1] <= 'z') || (arr[i - 1] >= 'A' && arr[i - 1] <= 'Z')) {
                amount++;
            }
        }
    } console.log(amount);
}
myfunction(paragraph);