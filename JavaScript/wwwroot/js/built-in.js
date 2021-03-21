
//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：将“飞哥”改成“大神”，“线下”改成“线上”。
//var string = "'源栈'：飞哥小班教学，线下免费收看";
//var result = string.replace("飞哥", "大神").replace("线下", "线上");

//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，让所有元素：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
//var array = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//for (var i = 0; i < array.length; i++) {
//    console.log(array[i][0].toUpperCase() + array[i].substring(1, 6).toLowerCase());
//}

//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以)

//在上述数组头部加上小鱼老师，末尾加上大飞哥
//var array = [1, 2, 3];
//array.unshift("小鱼老师");
//array.push("大飞哥");

//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
function getRandomArray(maxlength, max) {
    var array = [];
    arrlength = Math.floor(Math.random() * maxlength);
    for (var i = 0; i < arrlength; i++) {
        array[i] = Math.floor(Math.random() * max);
    }
    return array;
}
console.log(getRandomArray(5, 15));

//生成一个函数toChinese() ，可将传入的日期参数（如：new Date() ）转换成中文日期格式（如：2019年10月4日 16点54分）
function toChinese(date) {
    var cdate = new Date(date);
    var y = cdate.getFullYear();
    var m = cdate.getMonth() + 1;
    var d = cdate.getDate();
    var h = cdate.getHours();
    var minute = date.getMinutes();
    console.log(y + "年," + m + "月," + d + "日," + h + "时," + minute + "分");
}
toChinese("2017/08/15 04:20");

//生成一个函数addDays(number) ，可在当前日期的基础上增加number天
function addDays(dateTemp, days) {
    var Temp = dateTemp.split("-");
    //console.log("temp:"+Temp);
    var nDate = new Date(Temp[1] + '-' + Temp[2] + '-' + Temp[0]);
    //console.log("nDate:" +nDate);
    var millSeconds = Math.abs(nDate) + (days * 24 * 60 * 60 * 1000);
    //console.log("millSeconds:" +millSeconds);
    var rDate = new Date(millSeconds);
    //console.log("rDate:" +rDate);
    var year = rDate.getFullYear();
    var month = rDate.getMonth() + 1;
    if (month < 10) month = "0" + month;
    var date = rDate.getDate();
    if (date < 10) date = "0" + date;
    return (year + "年" + month + "月" + date + "日");
}
addDays("2015/04/08",5)
