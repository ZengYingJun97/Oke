package com.bnuz.oke.dao;

import com.bnuz.oke.entity.User;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

/**
 * UserDao
 *
 * @author handsome
 * @date 2020年 05月15日 23:17:02
 */
@Mapper
@Component
public interface UserDao {

	User queryByUsername(String username);

	void insertUser(User user);

	int updateUser(User user);
}
