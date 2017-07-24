//初始化脚本

//注册窗口命令的事件监视
/// 监听NanUI2窗口保留的最大化、最小化、还原、退出CSS标记的单击事件
/// 标记：
/// -nanui2-close		关闭窗口
/// -nanui2-maximize		最大化窗口
/// -nanui2-minimize		最小化窗口
(function () {
	document.addEventListener('DOMContentLoaded', function () {
		document.body.addEventListener('click', function (e) {
			var region = e.srcElement;
			var cmd = region.className.includes('-nanui2-close') ? 'close' : region.className.includes('-nanui2-minimize') ? 'minimize' : region.className.includes('-nanui2-maximize') ? 'maximize' : null;
			if (cmd != null && NanUI2) {
				NanUI2.hostWindow[cmd].apply();
				e.preventDefault();
				region.blur();
			}
		}, false);
	}, false);
})();
