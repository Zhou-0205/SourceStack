
//写一段代码，能根据一起帮用户的帮帮点（bCredit）输出他对应的等级
//var bCredit = 100;
//if (bCredit < 30) {
//    console.log("暂未等级");
//} else if (bCredit < 200) {
//    console.log("等级：聚气");
//} else if (bCredit < 1500) {
//    console.log("等级：萌芽");
//} else if (bCredit < 5000) {
//    console.log("等级：双叶");
//} else if (bCredit < 20000) {
//    console.log("等级：花开");
//} else {
//    console.log("等级：金童");
//}

//一起帮用户被分为5种，每种都有一个整数代号：
//0：访客
//1：注册用户
//2：文章发布者
//3：管理员
//4：超级管理员
//写一段代码，用switch...case将代号转换成文字输出，但3和4都统称“管理员”即可 
var userNumber = 5;
switch (userNumber) {
    case 0:
        console.log('访客');
        break;
    case 1:
        console.log('注册用户');
        break;
    case 2:
        console.log('文章发布者');
        break;
    case 3:
    case 4:
        console.log('管理员');
        break;
    default:
        console.log('没有此代号');
        break;
}

//alert("好好学习，天天向上");

//var sname;
//sname = "zdh";
//alert(sname);
//sname = "lw";
//alert(sname);
//sname = "lzb";
//alert(sname);

//var problem =
//{
//    title: "SqlServer查询",
//    body: "",
//    keyword: "SqlServer Query",
//    reward: 50,
//    needRemote: true,
//    help: "飞哥"
//}