//模拟求助首页，并：

//统计有多少个悬赏大于1的求助
var count = 0;
var reword = document.getElementById("id");
for (var i = 0; i < reword.length; i++) {
    if (parseInt(reword.innerText) > 1) {
        count++;
    }
    return count;
}
//将状态为“协助中”的求助背景改成灰黑色
document.getElementsByTagName("div")[2].firstElementChild.setAttribute("style", "background-color:black");
//如果总结数为0，将其从DOM树中删除
var sum = document.getElementsByTagName("div")[3].children[5];
if (parseInt(sum.innerText) === 0) {
    sum.remove();
}
//写一个函数getKeywordsCount() ，可以统计某个求助使用了多少关键字
function getKeywordsCount(id) {
    var keywords = document.getElementById("id").getElementsByName("keyword")[0].children.length;
    return keywords;
}
//参考用户注册页面，显示错误提示：

//密码的长度不能小于4
document.getElementsByName("password").onblur = function () {
    if (this.Value.length < 4) {
        this.nextElementSibling.style = "display:block;background-color:blue;"
    }
}

//密码和确认密码必须一致
document.getElementsByName("confirmpassword").onblur = function () {
    var password = document.getElementsByName("password").Value;
    if (this.Value !== password.Value) {
        this.nextElementSibling.style = "display:block;background-color:blue;"
    }
}
//参考用户资料页面，控制台显示出用户的：性别 / 省份 / 自我介绍
var gender = document.getElementsByName("gender");
for (var i = 0; i < gender.length; i++) {
    if (gender[i].checked) {
        console.log(gender[i].nextSibling);
    }
}
var province = document.getElementsByName("province")[0].selectedOptions[0].innerText;
console.log("省份" + province);
var introduction = document.getElementsByName("self-introduction").innerText;
console.log("自我介绍" + introduction);
//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果
setInterval(function () {
    var bell = document.getElementById('bell');
    if (bell.style.color !== 'blue') {
        bell.setAttribute("style", "color:blue");
    }
    else {
        bell.setAttribute("style", "color:red");
    }
}, 1000);