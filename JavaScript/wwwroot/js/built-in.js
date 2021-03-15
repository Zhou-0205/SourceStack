
//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：将“飞哥”改成“大神”，“线下”改成“线上”。
//var string = "'源栈'：飞哥小班教学，线下免费收看";
//var result = string.replace("飞哥", "大神");
//console.log(result.replace("线下", "线上"));

//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，让所有元素：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
//var array = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//var arr = [];
//var a = [];
//for (var i = 0; i < array.length; i++) {
//    arr[i] = array[i].substring(0, 6);
//    a[i] = arr[i].toUpperCase();
//    console.log(a[i].substring(1, 6).toLowerCase());
//}

//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//var reg = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
//是否是小数（正负小数都可以）
//在上述数组头部加上小鱼老师，末尾加上大飞哥
var array = [1, 2, 3];
array.unshift("小鱼老师");
array.push("大飞哥");
//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
function getRandomArray(length, max) {
    var array = [];
    for (var i = 0; i < Math.floor(Math.random() * length); i++) {
        array[i] = Math.floor(Math.random() * max);
    }
    return array;
}
console.log(getRandomArray(5, 15));
//生成一个函数toChinese() ，可将传入的日期参数（如：new Date() ）转换成中文日期格式（如：2019年10月4日 16点54分）
var date = new Date("2020/02/02 02:20");
function toChinese(date) {
    var newdate = date.getFullyear + "年"
        + (date.getMonth + 1) + "月"
        + date.getDate + "日"
        + date.getHours + "时"
        + date.getMinutes + "分";
    return newdate;
}
//生成一个函数addDays(number) ，可在当前日期的基础上增加number天
function addDays(number) {
    newdate = date.setDate(getDate + number);
    return newdate;
}
