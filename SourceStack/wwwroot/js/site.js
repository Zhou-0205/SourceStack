//var body = "<a href='http://17bang.ren' target='_blank'>源栈·一起帮</a>，助你实现<span style='font - size: 16px;'>编程</span>梦想！"
//用一个变量替换“编程”，以便输出更多内容。比如：助你实现{ 职业 } 梦想、助你实现{ 人生 } 梦想 
//var name = '职业';
//console.log('助你实现' + '{' + name + '}' + '梦想');
//设计一段代码，实现以下逻辑：
//某用户有一定数量的帮帮豆（sum）
//每点赞一次就会消耗若干帮帮豆（consume）
//现在用户点赞若干次（count）
//计算用户剩余了多少帮帮豆（banlance）并用bool值显示他是否还有帮帮豆（isAvailable）
//var sum = 100,
//    consume = 10,
//    count = 5,
//    banlance,
//    isAvailable;
//banlance = sum - (consume * count);
//isAvailable = banlance > 0;

//声明一个数组odds，利用循环把100以内的奇数按从小到大的顺序存入其中
//var odds = [], ji = 0;
//for (var i = 1; i < 100; i += 2) {
//    while (ji < 50) {
//        odds[ji] = i;
//        ji++;
//        break;
//    }
//}
//console.log(odds);  

//计算从odds数组中所有元素的和
//var sum = 0;
//for (var j = 0; j < odds.length; j++) {
//    sum += odds[j];
//}
//console.log(sum);

//找到数组中的最小值
//var arr = [14, 25, 32, 45, 23, 56, 23],
//min = arr[0];
//for (var i = 1; i < arr.length; i++) {
//    if (min > arr[i]) {
//        min = arr[i];
//    } //else nothing
//}
//console.log(min);


//输出用空格代替0的杨辉三角形
//var rows = 5,
//    columns = rows * 2 - 1;
//var yh = [];
//for (var i = 0; i < rows; i++) {
//    yh[i] = [];
//    var lines = ' ';
//    for (var j = 0; j < columns; j++) {
//        if (i === 0) {
//            yh[i][j] = (j === rows - 1) ? 1 : ' ';
//        } else {
//            var preRow = i - 1,
//                preColumn = (j - 1 >= 0) ? +yh[preRow][j - 1] : 0,
//                nextColumn = (j + 1 < columns) ? +yh[preRow][j + 1] : 0;
//            var current = preColumn + nextColumn;
//            yh[i][j] = current ? current : ' ';
//        }
//        lines += yh[i][j] + '   ';
//    }
//    console.log(lines);
//}

//输出1000以内的所有“素数 / 质数”
//for (var i = 2; i <= 1000; i++) {
//    for (var j = 2; j < i; j++) {
//        if (i % j === 0) {
//            break;
//        } /*else continue;*/ 
//        if (i - 1 === j) {
//            console.log(i);
//        }
//    }
//}

//冒泡排序
//var arr = [14, 25, 32, 45, 23, 56, 23],
//    temp;
//for (var i = 0; i < arr.length; i++) {
//    for (var j = 0; j < arr.length - 1; j++) {
//        if (arr[i] > arr[i + 1]) {
//            temp = arr[i];
//            arr[i] = arr[i + 1];
//            arr[i + 1] = temp;
//        }
//    }
//}

//二分查找 
//var array = [2, 5, 7, 34, 65, 77, 98],
//    target = 77;
//var left = 0,
//    right = array.length - 1,
//    middle = 0;
//while (left <= right) {
//    middle = Math.floor((left + right) / 2)
//    if (target > array[middle]) {
//        left = middle + 1;
//    }
//    else if (target < array[middle]) {
//        right = middle - 1;
//    }
//    else {
//        console.log(middle);
//        break;
//    }
//}

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
//var userNumber = 5;
//switch (userNumber) {
//    case 0:
//        console.log('访客');
//        break;
//    case 1:
//        console.log('注册用户');
//        break;
//    case 2:
//        console.log('文章发布者');
//        break;
//    case 3:
//    case 4:
//        console.log('管理员');
//        break;
//    default:
//        console.log('没有此代号');
//        break;
//}

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