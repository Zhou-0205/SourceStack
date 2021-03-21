//一个“前一页”按钮，点击可以跳到上一页；一个“下一页”按钮，点击可以跳到下一页；
document.getElementById("previous").addEventListener('click', function () {
    history.back();
})
document.getElementById("next").addEventListener('click', function () {
    history.forward();
})
//一个a标签，点击不会跳转到href指定页面，而是将href的值赋值给下面的一个文本框，
document.getElementById("a").addEventListener('click', function (event) {
    event.preventDefault;
    document.getElementById("text").Value = this.href;
})
//一个“转到”按钮，点击该按钮页面可跳转到文本框指定的网址页面
document.getElementById("goto").addEventListener('click', function () {
    location.assign(document.getElementById("text").Value);
})

//参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数
document.getElementsByName("keyword")[0].children.onmouseover = function () {
    this.setAttribute("title", "使用10次");
}
//参考一起帮首页，实现右侧漂浮并底对齐左侧文本框的效果
//参考消息页面：完成勾选全选功能
document.getElementsByName("check-all")[0].addEventListener('click', function () {
    var single = document.getElementsByTagName("div")[0].children;
    if (this.checked) {
        single.checked = true;
    }
    else {
        single.checked = false;
    }
})
//参考注册页面：

//提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
var oldname = ["小明", "小红"];
document.getElementsByTagName("form")[0].onsubmit = function (event) {
    var newname = document.getElementsByName("username")[0];
    for (var i = 0; i < oldname.length; i++) {
        if (oldname[i] === newname.Value) {
            event.preventDefault();
            newname.nextElementSibling.style = "display:block;background-color:blue;"
            break;
        } /*else nothing;*/
    }
}
//重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
document.getElementsByName("username")[0].onkeyup = function () {
    for (var i = 0; i < oldname.length; i++) {
        if (this.Value !== oldname[i]) {
            this.nextElementSibling.style = "display:none;"
        } /*else nothing;*/
    }
}
//当用户名或密码等有值时，关闭页面前弹出确认框
window.onbeforeunload() = function () {
    var name = document.getElementsByName("username")[0].Value;
    var password = document.getElementsByName("password")[0].Value;
    if (name || password !== null) {
        confirm("确认关闭吗");
    } /*else nothing;*/
}
//参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：

//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用
document.getElementsByName("modification")[0].addEventListener('click', function () {
    var count = document.getElementsByName("count")[0];
    if (this.checked) {
        count.setAttribute("disabled", "disabled");
    }
    else {
        count.disabled = "";
    }
})

