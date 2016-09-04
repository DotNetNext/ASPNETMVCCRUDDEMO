/// <reference path="_references.js" />
var $page = function () {

    this.init = function () {
        addEvent();//注册事件
    };
    function addEvent() {

        //搜索
        $("#btnSearch").click(function () {
            window.location.href = "/List/Index?pageIndex={0}&title={1}".ejq_format(1, encodeURI($("#txtTitle").val()));
        })

        //添加按钮事件
        $("#btnAdd").click(function () {
            insert();
        });

        //保存
        $("#btnSave").click(function () {
            var isAdd = $("#pk").val() == "" || $("#pk").val() == 0;
            $.ajax({
                url: isAdd ? "/list/insert" : "/list/update",
                data: $('#frmInsertAndUpate').serialize(),
                cache: false,
                type:"post",
                success: function (msg) {
                    if (msg.IsSuccess) {
                        alert("保存成功！");
                        window.location.reload();
                    } else {
                        alert("保存失败！");
                    }
                },
                error: function (msg) {
                    console.log(msg);
                }
            })

        });

    }
};

//删除
function del(id) {
    var isCon = confirm("确定要删除吗?");
    if (isCon == false) return;
    $.ajax({
        url: "/list/Delete",
        data: { id, id},
                cache: false,
                success: function (msg) {
                    if (msg.IsSuccess) {
                        alert("删除成功！");
                        window.location.reload();
                    } else {
                        alert("删除失败！");
                    }
                },
        error: function (msg) {
            console.log(msg);
        }
    })
}
//初始化编辑
function update(id) {
    $("#title").text("编辑");
    $.ajax({
        url: "/list/GetById",
        data: { id, id},
                cache: false,
                success: function (msg) {
                    $("#frmInsertAndUpate").formFill({ data: msg.ResultInfo })//填充表单
                },
        error: function (msg) {
            console.log(msg);
        }
    })
}
//初始化添加
function insert() {
    $("#title").text("添加");
    $("#frmInsertAndUpate").formClear();//清空表单
}


$(function () {

    var page = new $page();
    page.init();
})
