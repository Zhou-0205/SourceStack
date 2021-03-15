//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；（Math.floor(Math.random() * 1000) ）
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^
if (confirm("确认开始吗")) {
    var num = (Math.floor(Math.random() * 1000));
    console.log(num);
    for (var i = 0; i < 10; i++) {
        var input = prompt("请输入数字");
        if (input === num) {
            if (i < 6) {
                alert("碉堡了！");
            }
            if (i < 8) {
                alert("666！");
            }
            if (i < 10) {
                alert("猜到了。");
            }
            break;
        } else {
            if (i === 10) {
                alert("^ (*￣(oo) ￣)^");
            }
            else {
                alert(input > num ? "大了" : "小了");
            }
        }
    }
}
//分别使用setInterval()使用setTimeout()实现：每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
var n = 1;

setInterval(function () {
    console.log('第' + n + '周，源栈同学' + (Math.floor(Math.random() * 100)) + '人');
    n++;
}, 1000);

function enroll() {
    console.log('第' + n + '周，源栈同学' + (Math.floor(Math.random() * 100)) + '人');
    n++;
    setTimeout(enroll,1000);
}
enroll();