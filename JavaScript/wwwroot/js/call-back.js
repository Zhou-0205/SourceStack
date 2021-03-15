//使用“模拟名称空间”技术，构建一个函数函数yz.fei.get(number)
var yz = {};
yz.fei = {};
yz.fei = { get:function (number) { } };
//yz.fei.get(number, handler)除number以外，还可以接受任意多个回调函数handler做参数，
//得到：0到number间有多少个满足handler条件的整数。
    //回调函数handler能对number进行运算，并返回bool值的，比如has6()
    //get()函数调用回调函数进行运算，只要回调函数运行结果为真，就累加计数
    //最后返回累加值

//让yz.fei.get(number)调用实现之前“统计含9 / 8 / 6数字个数”的作业
var numbers = [343, 888, 657, 777, 365, 234, 798, 456, 987];

yz.fei = {
    get: function (number, handler) {
        var amount = 0;
        if (handler(number)) {
            amount++;
        }
        return amount;
    }
}
yz.fei.get(numbers, get986());